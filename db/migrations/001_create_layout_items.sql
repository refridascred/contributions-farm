-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, weight, score, state, token) VALUES (23, 69.04, 89.32, 'primary', 'staging');
INSERT INTO layout_items (active, weight, score, state, token) VALUES (86, 5.14, 3.06, 'blue', 'cached');
INSERT INTO layout_items (active, weight, score, state, token) VALUES (54, 23.99, 50.03, 'staging', 'staging');
