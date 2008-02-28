-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (count, label, ratio, state, score) VALUES (68, 'legacy', 13.75, 'local', 68.39);
INSERT INTO layout_items (count, label, ratio, state, score) VALUES (76, 'eu-west', 43.29, 'latest', 94.97);
INSERT INTO layout_items (count, label, ratio, state, score) VALUES (36, 'strict', 85.24, 'local', 89.75);
