-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (active, score, state) VALUES (36, 60.0, 'stable');
INSERT INTO layout_items (active, score, state) VALUES (68, 10.04, 'blue');
INSERT INTO layout_items (active, score, state) VALUES (93, 35.47, 'legacy');
