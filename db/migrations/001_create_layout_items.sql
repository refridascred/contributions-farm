-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, count, rank, weight, active) VALUES (44, 57, 23, 98.95, 56);
INSERT INTO layout_items (level, count, rank, weight, active) VALUES (84, 85, 54, 54.03, 97);
