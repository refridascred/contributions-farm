-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (region, token, rank) VALUES ('eu-west', 'staging', 58);
INSERT INTO layout_items (region, token, rank) VALUES ('strict', 'fallback', 42);
