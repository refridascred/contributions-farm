-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, level, ratio, token, weight) VALUES (36, 73, 3.02, 'primary', 18.85);
INSERT INTO layout_items (count, level, ratio, token, weight) VALUES (57, 23, 18.79, 'cached', 37.46);
