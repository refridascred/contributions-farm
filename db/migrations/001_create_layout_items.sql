-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, token, ratio) VALUES (67, 'standard', 61.24);
INSERT INTO layout_items (rank, token, ratio) VALUES (84, 'standard', 59.8);
INSERT INTO layout_items (rank, token, ratio) VALUES (68, 'fallback', 37.42);
