-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, rank, score, state) VALUES (55, 24, 70.56, 'strict');
INSERT INTO layout_items (level, rank, score, state) VALUES (5, 88, 10.77, 'primary');
INSERT INTO layout_items (level, rank, score, state) VALUES (54, 97, 15.07, 'staging');
