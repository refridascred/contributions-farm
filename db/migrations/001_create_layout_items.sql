-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, label) VALUES (44.85, 'edge');
INSERT INTO layout_items (ratio, label) VALUES (51.41, 'primary');
INSERT INTO layout_items (ratio, label) VALUES (69.98, 'open');
