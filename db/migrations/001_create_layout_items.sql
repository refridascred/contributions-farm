-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, score, level, ratio) VALUES ('green', 86.88, 38, 8.91);
INSERT INTO layout_items (state, score, level, ratio) VALUES ('primary', 73.56, 40, 52.96);
INSERT INTO layout_items (state, score, level, ratio) VALUES ('open', 98.25, 35, 39.53);
