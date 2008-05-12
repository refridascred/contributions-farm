-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, level) VALUES ('strict', 43, 35);
INSERT INTO layout_items (token, rank, level) VALUES ('local', 14, 79);
