-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (count, active, region) VALUES (16, 23, 'blue');
INSERT INTO layout_items (count, active, region) VALUES (69, 74, 'stable');
INSERT INTO layout_items (count, active, region) VALUES (50, 25, 'staging');
