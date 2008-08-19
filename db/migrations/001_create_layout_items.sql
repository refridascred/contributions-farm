-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (state, rank, weight, label) VALUES ('open', 51, 50.06, 'eu-west');
INSERT INTO layout_items (state, rank, weight, label) VALUES ('open', 86, 21.19, 'stable');
INSERT INTO layout_items (state, rank, weight, label) VALUES ('open', 44, 8.93, 'blue');
