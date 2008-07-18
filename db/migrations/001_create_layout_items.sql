-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (active, weight, level, state, score) VALUES (41, 32.74, 42, 'staging', 85.03);
INSERT INTO layout_items (active, weight, level, state, score) VALUES (31, 39.46, 39, 'latest', 69.07);
