-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, active, region, weight) VALUES (69, 66, 'standard', 25.52);
INSERT INTO layout_items (count, active, region, weight) VALUES (17, 19, 'strict', 8.93);
INSERT INTO layout_items (count, active, region, weight) VALUES (31, 14, 'green', 64.52);
