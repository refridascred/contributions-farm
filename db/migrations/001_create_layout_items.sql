-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, score, token, state) VALUES (87, 43.4, 31.57, 'stable', 'primary');
INSERT INTO layout_items (level, weight, score, token, state) VALUES (7, 27.03, 45.64, 'latest', 'fallback');
INSERT INTO layout_items (level, weight, score, token, state) VALUES (87, 0.21, 28.54, 'latest', 'fallback');
