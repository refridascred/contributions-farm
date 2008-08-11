-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, ratio, rank, level) VALUES ('stable', 16.85, 49, 70);
INSERT INTO layout_items (label, ratio, rank, level) VALUES ('standard', 70.5, 62, 20);
INSERT INTO layout_items (label, ratio, rank, level) VALUES ('edge', 76.29, 64, 78);
