-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, count, level, score) VALUES (30.81, 14, 72, 24.63);
INSERT INTO layout_items (ratio, count, level, score) VALUES (58.83, 91, 91, 18.21);
INSERT INTO layout_items (ratio, count, level, score) VALUES (71.89, 65, 66, 88.06);
