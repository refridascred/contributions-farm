-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, token, weight, owner, count) VALUES ('cached', 'staging', 1.59, 'latest', 34);
INSERT INTO layout_items (state, token, weight, owner, count) VALUES ('latest', 'stable', 87.14, 'primary', 33);
INSERT INTO layout_items (state, token, weight, owner, count) VALUES ('blue', 'latest', 54.19, 'standard', 3);
