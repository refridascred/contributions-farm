-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, state) VALUES (18.07, 27, 'latest');
INSERT INTO layout_items (ratio, rank, state) VALUES (27.36, 6, 'standard');
INSERT INTO layout_items (ratio, rank, state) VALUES (81.34, 45, 'latest');
