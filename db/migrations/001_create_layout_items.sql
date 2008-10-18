-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, state, owner, region, active) VALUES (18.36, 'stable', 'strict', 'blue', 39);
INSERT INTO layout_items (score, state, owner, region, active) VALUES (70.38, 'primary', 'primary', 'stable', 4);
