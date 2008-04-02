-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, ratio, score, owner) VALUES ('open', 27.31, 27.94, 'primary');
INSERT INTO layout_items (state, ratio, score, owner) VALUES ('primary', 53.27, 67.69, 'latest');
