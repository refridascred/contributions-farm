-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, score, ratio) VALUES ('local', 27.47, 76.02);
INSERT INTO layout_items (state, score, ratio) VALUES ('local', 61.43, 43.47);
INSERT INTO layout_items (state, score, ratio) VALUES ('stable', 54.33, 38.65);
