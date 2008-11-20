-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, state, token, region) VALUES ('local', 'open', 'primary', 'staging');
INSERT INTO layout_items (label, state, token, region) VALUES ('latest', 'stable', 'green', 'legacy');
