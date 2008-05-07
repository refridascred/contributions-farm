-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, level, label) VALUES (98, 81, 'fallback');
INSERT INTO layout_items (rank, level, label) VALUES (82, 9, 'latest');
INSERT INTO layout_items (rank, level, label) VALUES (77, 31, 'standard');
