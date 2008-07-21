-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, score, level) VALUES (27, 'primary', 69.0, 77);
INSERT INTO layout_items (active, state, score, level) VALUES (19, 'blue', 61.59, 52);
INSERT INTO layout_items (active, state, score, level) VALUES (38, 'primary', 88.19, 22);
