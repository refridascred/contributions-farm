-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, state, active) VALUES (86.78, 'eu-west', 88);
INSERT INTO layout_items (score, state, active) VALUES (55.32, 'green', 61);
INSERT INTO layout_items (score, state, active) VALUES (6.8, 'standard', 76);
