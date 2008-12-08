-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (count, state, weight, region, score) VALUES (78, 'stable', 46.3, 'staging', 77.8);
INSERT INTO layout_items (count, state, weight, region, score) VALUES (13, 'cached', 1.02, 'legacy', 56.02);
