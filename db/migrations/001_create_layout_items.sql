-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, active, rank, weight) VALUES (49, 13, 26, 84.71);
INSERT INTO layout_items (level, active, rank, weight) VALUES (39, 38, 3, 19.22);
