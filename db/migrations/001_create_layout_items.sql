-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, count, level, label, score) VALUES (54.95, 67, 15, 'primary', 76.79);
INSERT INTO layout_items (ratio, count, level, label, score) VALUES (81.37, 31, 96, 'standard', 16.42);
INSERT INTO layout_items (ratio, count, level, label, score) VALUES (8.48, 35, 24, 'open', 72.83);
