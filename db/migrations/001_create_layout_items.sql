-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, state, score) VALUES (77, 'local', 50.44);
INSERT INTO layout_items (active, state, score) VALUES (99, 'local', 58.7);
INSERT INTO layout_items (active, state, score) VALUES (45, 'eu-west', 41.61);
