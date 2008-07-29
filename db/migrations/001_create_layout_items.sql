-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, ratio, count, active) VALUES (58.63, 86.92, 11, 41);
INSERT INTO layout_items (weight, ratio, count, active) VALUES (47.38, 67.08, 12, 99);
