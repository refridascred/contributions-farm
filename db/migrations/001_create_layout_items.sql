-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (score, state, weight, token, rank) VALUES (21.96, 'stable', 70.69, 'local', 19);
INSERT INTO layout_items (score, state, weight, token, rank) VALUES (59.17, 'open', 47.94, 'eu-west', 78);
INSERT INTO layout_items (score, state, weight, token, rank) VALUES (60.51, 'primary', 29.54, 'cached', 58);
