-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, active, rank, region, score) VALUES ('primary', 11, 65, 'blue', 62.79);
INSERT INTO layout_items (state, active, rank, region, score) VALUES ('cached', 26, 3, 'eu-west', 95.17);
INSERT INTO layout_items (state, active, rank, region, score) VALUES ('cached', 71, 18, 'open', 94.6);
