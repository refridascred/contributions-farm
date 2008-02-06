-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, rank, active) VALUES ('staging', 73, 53);
INSERT INTO layout_items (region, rank, active) VALUES ('standard', 67, 10);
INSERT INTO layout_items (region, rank, active) VALUES ('standard', 51, 6);
