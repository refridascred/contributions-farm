-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (level, active, rank, weight, count) VALUES (60, 99, 45, 23.23, 73);
INSERT INTO layout_items (level, active, rank, weight, count) VALUES (69, 72, 61, 34.32, 96);
