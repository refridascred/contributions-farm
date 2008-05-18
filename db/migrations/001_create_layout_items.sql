-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, label) VALUES (9.93, 34, 'blue');
INSERT INTO layout_items (ratio, rank, label) VALUES (78.75, 57, 'cached');
INSERT INTO layout_items (ratio, rank, label) VALUES (25.93, 99, 'eu-west');
