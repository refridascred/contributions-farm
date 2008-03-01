-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, label, ratio) VALUES (66, 'primary', 96.37);
INSERT INTO layout_items (rank, label, ratio) VALUES (19, 'latest', 50.64);
INSERT INTO layout_items (rank, label, ratio) VALUES (36, 'primary', 37.03);
