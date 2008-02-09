-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, level, weight, state, ratio) VALUES (55, 32, 76.86, 'green', 84.04);
INSERT INTO layout_items (count, level, weight, state, ratio) VALUES (43, 14, 81.97, 'latest', 15.31);
