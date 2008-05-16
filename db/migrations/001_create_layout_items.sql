-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, ratio) VALUES ('standard', 77.91);
INSERT INTO layout_items (owner, ratio) VALUES ('stable', 57.11);
INSERT INTO layout_items (owner, ratio) VALUES ('standard', 78.43);
