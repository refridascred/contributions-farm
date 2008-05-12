-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, token, rank, weight) VALUES ('standard', 'eu-west', 97, 11.36);
INSERT INTO layout_items (state, token, rank, weight) VALUES ('local', 'stable', 22, 52.54);
INSERT INTO layout_items (state, token, rank, weight) VALUES ('strict', 'blue', 29, 39.02);
