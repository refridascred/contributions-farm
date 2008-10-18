-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, score, weight) VALUES ('open', 'edge', 76.43, 93.42);
INSERT INTO layout_items (state, owner, score, weight) VALUES ('edge', 'stable', 41.71, 15.07);
INSERT INTO layout_items (state, owner, score, weight) VALUES ('cached', 'standard', 87.65, 24.57);
