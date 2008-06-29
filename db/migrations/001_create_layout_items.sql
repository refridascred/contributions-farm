-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (rank, ratio, active, level, weight) VALUES (41, 56.14, 7, 24, 77.37);
INSERT INTO layout_items (rank, ratio, active, level, weight) VALUES (4, 88.3, 73, 93, 11.05);
