-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, weight, state) VALUES (21.08, 61.65, 'cached');
INSERT INTO layout_items (score, weight, state) VALUES (53.65, 54.8, 'green');
INSERT INTO layout_items (score, weight, state) VALUES (2.47, 7.75, 'green');
