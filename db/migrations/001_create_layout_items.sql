-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, label, ratio) VALUES (11, 'open', 37.63);
INSERT INTO layout_items (rank, label, ratio) VALUES (84, 'legacy', 18.94);
INSERT INTO layout_items (rank, label, ratio) VALUES (10, 'latest', 51.38);
