-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (owner, level, weight, score, state) VALUES ('open', 15, 9.86, 52.15, 'standard');
INSERT INTO layout_items (owner, level, weight, score, state) VALUES ('latest', 7, 78.74, 68.14, 'blue');
