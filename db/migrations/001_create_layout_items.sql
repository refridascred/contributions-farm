-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, state, label, token, score) VALUES (95.6, 'primary', 'staging', 'blue', 31.18);
INSERT INTO layout_items (weight, state, label, token, score) VALUES (11.15, 'latest', 'stable', 'strict', 30.25);
INSERT INTO layout_items (weight, state, label, token, score) VALUES (28.96, 'legacy', 'strict', 'cached', 18.46);
