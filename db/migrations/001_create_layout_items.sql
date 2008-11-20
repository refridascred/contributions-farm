-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, rank, owner, score, ratio) VALUES ('primary', 73, 'stable', 20.85, 66.1);
INSERT INTO layout_items (state, rank, owner, score, ratio) VALUES ('cached', 32, 'blue', 9.07, 32.55);
INSERT INTO layout_items (state, rank, owner, score, ratio) VALUES ('stable', 34, 'standard', 93.72, 19.51);
