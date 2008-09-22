-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, level, score) VALUES (2.31, 18, 72, 35.46);
INSERT INTO layout_items (ratio, active, level, score) VALUES (90.92, 75, 34, 44.61);
INSERT INTO layout_items (ratio, active, level, score) VALUES (52.15, 16, 3, 22.87);
