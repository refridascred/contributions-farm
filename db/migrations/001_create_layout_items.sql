-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, level, owner, state, weight) VALUES ('latest', 19, 'green', 'edge', 28.08);
INSERT INTO layout_items (token, level, owner, state, weight) VALUES ('local', 50, 'blue', 'stable', 34.64);
INSERT INTO layout_items (token, level, owner, state, weight) VALUES ('cached', 42, 'open', 'fallback', 6.72);
