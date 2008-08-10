-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, level, rank, label, region) VALUES ('blue', 27, 51, 'blue', 'strict');
INSERT INTO layout_items (owner, level, rank, label, region) VALUES ('eu-west', 40, 46, 'cached', 'primary');
INSERT INTO layout_items (owner, level, rank, label, region) VALUES ('standard', 0, 54, 'primary', 'latest');
