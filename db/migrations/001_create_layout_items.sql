-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, active, region) VALUES (22, 87, 'eu-west');
INSERT INTO layout_items (count, active, region) VALUES (54, 28, 'fallback');
INSERT INTO layout_items (count, active, region) VALUES (1, 18, 'edge');
