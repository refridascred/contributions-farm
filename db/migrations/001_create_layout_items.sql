-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, region, count) VALUES ('local', 'local', 15);
INSERT INTO layout_items (state, region, count) VALUES ('standard', 'legacy', 17);
INSERT INTO layout_items (state, region, count) VALUES ('local', 'legacy', 75);
