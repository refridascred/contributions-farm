-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, state, weight, count, ratio) VALUES ('stable', 'legacy', 12.98, 6, 59.92);
INSERT INTO layout_items (owner, state, weight, count, ratio) VALUES ('stable', 'edge', 83.47, 34, 58.27);
