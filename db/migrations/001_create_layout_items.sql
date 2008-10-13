-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, rank, token, label) VALUES ('legacy', 22, 'staging', 'latest');
INSERT INTO layout_items (region, rank, token, label) VALUES ('stable', 72, 'blue', 'open');
