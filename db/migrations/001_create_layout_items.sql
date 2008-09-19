-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, state, ratio) VALUES (84, 'local', 59.44);
INSERT INTO layout_items (rank, state, ratio) VALUES (64, 'eu-west', 87.94);
INSERT INTO layout_items (rank, state, ratio) VALUES (66, 'fallback', 56.31);
