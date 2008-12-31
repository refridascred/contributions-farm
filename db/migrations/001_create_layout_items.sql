-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, ratio) VALUES ('staging', 43.43);
INSERT INTO layout_items (label, ratio) VALUES ('edge', 83.57);
INSERT INTO layout_items (label, ratio) VALUES ('blue', 51.61);
