-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, ratio, active, rank, level) VALUES (93.2, 27.42, 34, 46, 98);
INSERT INTO layout_items (weight, ratio, active, rank, level) VALUES (7.76, 72.23, 98, 95, 86);
INSERT INTO layout_items (weight, ratio, active, rank, level) VALUES (64.35, 18.01, 63, 13, 89);
