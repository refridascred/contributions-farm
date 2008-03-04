-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (weight, token, state, owner, score) VALUES (35.41, 'legacy', 'latest', 'strict', 45.68);
INSERT INTO layout_items (weight, token, state, owner, score) VALUES (10.86, 'edge', 'local', 'eu-west', 21.73);
INSERT INTO layout_items (weight, token, state, owner, score) VALUES (18.07, 'open', 'latest', 'blue', 67.98);
