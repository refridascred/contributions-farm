-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (weight, state, score, level, token) VALUES (30.57, 'green', 39.26, 80, 'eu-west');
INSERT INTO layout_items (weight, state, score, level, token) VALUES (73.76, 'legacy', 7.62, 85, 'staging');
INSERT INTO layout_items (weight, state, score, level, token) VALUES (52.82, 'eu-west', 18.27, 68, 'latest');
