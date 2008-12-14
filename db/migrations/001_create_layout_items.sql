-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, state, region) VALUES ('open', 'local', 'legacy');
INSERT INTO layout_items (token, state, region) VALUES ('local', 'blue', 'standard');
INSERT INTO layout_items (token, state, region) VALUES ('strict', 'legacy', 'blue');
