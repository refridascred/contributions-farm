-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (state, score, weight, owner) VALUES ('blue', 93.88, 88.3, 'fallback');
INSERT INTO layout_items (state, score, weight, owner) VALUES ('eu-west', 83.73, 29.4, 'green');
INSERT INTO layout_items (state, score, weight, owner) VALUES ('latest', 27.86, 69.23, 'local');
