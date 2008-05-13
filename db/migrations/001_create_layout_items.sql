-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, label) VALUES ('blue', 'stable', 'fallback');
INSERT INTO layout_items (region, token, label) VALUES ('edge', 'legacy', 'stable');
