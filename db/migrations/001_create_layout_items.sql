-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (owner, state, score, count) VALUES ('strict', 'eu-west', 95.24, 70);
INSERT INTO layout_items (owner, state, score, count) VALUES ('blue', 'open', 53.82, 93);
INSERT INTO layout_items (owner, state, score, count) VALUES ('standard', 'green', 22.22, 61);
